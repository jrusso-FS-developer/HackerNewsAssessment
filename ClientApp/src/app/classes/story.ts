export class Story implements IStory {    
    by: string;
    descendants: number;
    id: number;
    kids: Array<number>;
    score: number;
    text: string;
    time: Date;
    title: string;
    type: string;
    url: string; 

    constructor(data: any = null) {
        if (data) {
            let time = new Date(0);
            time.setUTCSeconds(data.time);

            this.by = data.by;
            this.descendants = data.descendants;
            this.kids = data.kids;
            this.score = data.score;
            this.text = data.text;
            this.time = time;
            this.title = data.title;
            this.type = data.type;
            this.url = data.url;
        }
    }
}