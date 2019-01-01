import { CosmicSearchService } from "./CosmicSearchService";
import { inject } from "aurelia-framework";
import { OnlineCatalogItem } from "./Model/OnlineCatalogItem";

@inject(CosmicSearchService)
export class CosmicSearch {

    constructor(cosmicSearchService: CosmicSearchService) {

        this.searchService = cosmicSearchService;
        this.searchTermTitle = "";
        this.titleErrorMessage = "";
        this.searchResults = [];

    }

    public searchOnTitle() {

        this.titleErrorMessage = "";
        if (this.searchTermTitle.length <= 0) {
            this.titleErrorMessage = "You must provide a title for the search.";
        }

        this.searchService.searchOnTitle(this.searchTermTitle)
            .then(results => this.searchResults = results)
            .catch(err => this.titleErrorMessage = err);

    }

    public searchTermTitle: string;
    public titleErrorMessage: string;
    public searchResults: OnlineCatalogItem[];

    private searchService: CosmicSearchService;
}