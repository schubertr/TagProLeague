import * as auth0 from 'auth0-js';

export default class Auth {
	auth0 = new auth0.WebAuth({
		domain: 'taproleague.auth0.com',
		clientID: 'Dy0MGualzLv8MUr3nQH5Q8m7immo0WFp',
		redirectUri: 'http://localhost:57171/callback',
		responseType: 'token id_token',
		scope: 'openid'
	});

	login() {
		this.auth0.authorize();
	}
}