import { demoProjectTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: demoProjectTemplatePage;

  beforeEach(() => {
    page = new demoProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
