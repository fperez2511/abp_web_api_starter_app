import { WebApiTemplatePage } from './app.po';

describe('WebApi App', function() {
  let page: WebApiTemplatePage;

  beforeEach(() => {
    page = new WebApiTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
