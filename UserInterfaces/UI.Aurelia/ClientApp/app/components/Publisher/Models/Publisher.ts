export class Publisher {

    constructor(id: number, name: string, siteUrl: string) {

        this.Id = id;
        this.Name = name;
        this.SiteUrl = siteUrl;

    }

    public Id?: number;
    public Name: string;
    public SiteUrl: string;

}