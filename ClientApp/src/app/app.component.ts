import { Component, OnInit } from '@angular/core';
import { HackerNewsService } from './services/hacker-news.service';
import { Story } from './classes/story';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  stories: Array<IStory>;

  constructor(public hackerNewsService: HackerNewsService){  
    this.stories = new Array<IStory>();  
  }

  ngOnInit(){
    this.hackerNewsService.getStories()
      .subscribe((data) => {
        this.stories = new Array<IStory>();  

        data.map(s => {
          this.stories.push(new Story(s));
        })
      })
  }
}
