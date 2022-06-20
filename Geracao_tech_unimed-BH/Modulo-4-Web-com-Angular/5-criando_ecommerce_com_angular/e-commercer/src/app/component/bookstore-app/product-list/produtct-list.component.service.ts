import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Book } from "./model/Books";

@Injectable()
export class BookService{

    private url = ''

    httpOpitions = { 
        Headers: new HttpHeaders({'content-type': 'application/json'})
    }

    constructor(private http:HttpClient){}

    getBook(){
        return this.http.get(this.url)
    }

}

