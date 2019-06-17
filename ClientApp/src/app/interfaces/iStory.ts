interface IStory {
    by: string,
    descendants: number,
    id: number,
    kids: Array<number>,
    score: number,
    text: string;
    time: Date,
    title: string,
    type: string,
    url: string    
}