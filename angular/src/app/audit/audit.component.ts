import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from 'shared/paged-listing-component-base';
import { AuditServiceProxy, AuditDto, PagedResultDtoOfAuditDto } from '@shared/service-proxies/service-proxies';
import { Moment } from 'moment';

@Component({
    templateUrl: './audit.component.html',
    styleUrls: ['./audit.component.css'],
  animations: [appModuleAnimation()]
})
export class AuditComponent extends PagedListingComponentBase<AuditDto> {

	auditRecords: AuditDto[] = [];

	constructor(
		private injector:Injector,
		private _auditRecordsService: AuditServiceProxy
	) {
		super(injector);
	}
  
    protected list(
        request: PagedRequestDto,
        pageNumber: number,
        finishedCallback: Function
    ): void {

        this._auditRecordsService
            .getAll(request.maxResultCount, request.skipCount)
            .pipe(
                finalize(() => {
                    finishedCallback();
                })
            )
            .subscribe((result: PagedResultDtoOfAuditDto) => {
				this.auditRecords = result.items;
				this.showPaging(result, pageNumber);
		});
	}
	
	protected delete(role: AuditDto): void { }
}
