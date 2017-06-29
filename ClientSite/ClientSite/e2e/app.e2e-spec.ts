import { ClientSitePage } from './app.po';

describe('client-site App', () => {
  let page: ClientSitePage;

  beforeEach(() => {
    page = new ClientSitePage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
