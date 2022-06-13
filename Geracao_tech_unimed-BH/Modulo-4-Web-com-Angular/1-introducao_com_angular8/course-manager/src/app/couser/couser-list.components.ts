import { Component, OnInit } from "@angular/core";
import { Course } from "./course";

@Component({
    selector: 'app-course-list',
    // template: '<h2> Course List </h2>' 
    templateUrl: './couser-list.components.html' 
})
export class CourseListComponent implements OnInit {
    courses: Course[] = []

    ngOnInit(): void {
        this.courses = [
            {
                id: 1,
                name: 'Angular: Forms',
                imageURL: '/assets/image/forms.png',
                price: 99.99,
                code: 'xps-9-8796',
                duration: 26,
                rating: 4.5,
                releaseDate: '2 Novembro 2019'

            },
            {
                id: 2,
                name: 'Angular: HTTP',
                imageURL: '/assets/image/http.png',
                price: 45.99,
                code: 'lks-9-3596',
                duration: 88,
                rating: 3.5,
                releaseDate: '4 Dezembro 2019'

            }
        ]
    }
}