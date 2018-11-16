import OktaAuth from '@okta/okta-auth-js'

const org = 'https://dev-493411.oktapreview.com',
  clientId = '0oahjhk6l8Tfo0M2v0h7',
  redirectUri = 'http://localhost:5000',
  authorizationServer = 'default'

const oktaAuthClient = new OktaAuth({
  url: org,
  issuer: authorizationServer,
  clientId,
  redirectUri
})

export default {
  client: oktaAuthClient
}
