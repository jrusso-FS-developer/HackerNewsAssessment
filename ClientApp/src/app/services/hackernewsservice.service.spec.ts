import { TestBed } from '@angular/core/testing';

import { HackernewsserviceService } from './hackernewsservice.service';

describe('HackernewsserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: HackernewsserviceService = TestBed.get(HackernewsserviceService);
    expect(service).toBeTruthy();
  });
});
