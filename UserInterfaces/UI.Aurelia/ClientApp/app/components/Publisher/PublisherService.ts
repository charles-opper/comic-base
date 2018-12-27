import { HttpClient } from "aurelia-fetch-client";
import { inject } from "aurelia-framework";
import { Publisher } from "./Models/Publisher";

@inject(HttpClient)
export class PublisherService {

    constructor(httpClient: HttpClient) {
        this._httpClient = httpClient;
    }

    public async GetPublishers(): Promise<Publisher[]> {

        let publishers: Publisher[] = [];

        await this._httpClient.fetch('api/publisher')
            .then(result => result.json() as Promise<Publisher[]>)
            .then(data => {
                publishers = data;
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

        return publishers;

    }

    private _httpClient: HttpClient;
}