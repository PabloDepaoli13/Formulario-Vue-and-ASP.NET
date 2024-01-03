export class ContratoService {

    static URL_API = 'http://localhost:5232/api/';

    static async getContrato(contratoId) {

        let dataURL = this.URL_API + `Contract/${contratoId}`;
        var response = await fetch(dataURL, {
            "method": 'GET',
            "mode": 'cors',
            "headers": {
                "Content-Type": 'aplication/json'
            }
        }).then(response => response.json());
        return response;
    }
}