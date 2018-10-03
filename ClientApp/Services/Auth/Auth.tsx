import * as auth0 from 'auth0-js';

export default class Auth {
	auth0 = new auth0.WebAuth({
		domain: 'markhollis.auth0.com',
		clientID: 'CGGC-nBID0jhzDmJPgYrmmbkoMKnxmfb',
		redirectUri: 'http://localhost:63087/callback',
		responseType: 'token id_token',
		scope: 'openid'
	});

	login() {
		this.auth0.authorize();
	}
}