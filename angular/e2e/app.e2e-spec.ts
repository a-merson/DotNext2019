import { DotNextDemoTemplatePage } from './app.po';

describe('DotNextDemo App', function() {
  let page: DotNextDemoTemplatePage;

  beforeEach(() => {
    page = new DotNextDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
