import { Publisher } from "../../Publisher/Models/Publisher";

export class Issue {

    constructor(title: string, publisherId: number, publisher: Publisher, volume: number, issueNumber: number, year: number) {

        this.Title = title;
        this.PublisherId = publisherId;
        this.Publisher = publisher;
        this.Volume = volume;
        this.IssueNumber = issueNumber;
        this.Year = year;

    }

    public Id?: number;
    public Title: string;
    public PublisherId: number;
    public Publisher: Publisher;
    public Volume: number;
    public IssueNumber: number;
    public Year: number;

}