import { HttpClient } from "aurelia-fetch-client";
import { inject } from "aurelia-framework";
import { OnlineCatalogItem } from "./Model/OnlineCatalogItem";

@inject(HttpClient)
export class CosmicSearchService {

    constructor(httpClient: HttpClient) {

        this.httpClient = httpClient;
        this.searchResultsCache = new Map();
    }

    public async searchOnTitle(title: string): Promise<OnlineCatalogItem[]> {

        var searchKey = title.toLowerCase();

        if (this.searchResultsCache.has(searchKey)) {

            return this.searchResultsCache.get(searchKey) || [];

        }

        let items: OnlineCatalogItem[] = [];

        var url = CosmicSearchService.searchUrl + "?title=" + searchKey;
            await this.httpClient.fetch(url)
                .then(result => result.json() as Promise<OnlineCatalogItem[]>)
                .then(data => {
                    this.searchResultsCache.set(searchKey, data);
                    items = data;
                })
                .catch(err => alert(err));

        return items;
    }

    private static readonly searchUrl: string = "api/cosmicsearch/";

    private httpClient: HttpClient;
    private searchResultsCache: Map<string, OnlineCatalogItem[]>;

}