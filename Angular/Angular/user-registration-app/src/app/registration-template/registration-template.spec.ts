import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrationTemplate } from './registration-template';

describe('RegistrationTemplate', () => {
  let component: RegistrationTemplate;
  let fixture: ComponentFixture<RegistrationTemplate>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegistrationTemplate]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegistrationTemplate);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
