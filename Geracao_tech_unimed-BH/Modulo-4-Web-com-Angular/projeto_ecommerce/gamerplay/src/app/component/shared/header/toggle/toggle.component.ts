import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toggle',
  templateUrl: './toggle.component.html',
  styleUrls: ['./toggle.component.css']
})
export class ToggleComponent implements OnInit {

  constructor() { }

  display = 'none'

  ngOnInit(): void {

  }

  toggle(){    
    if(this.display == 'block'){
      this.display = 'none' 
    }
    else{
      this.display = 'block'
    }
  }

}
