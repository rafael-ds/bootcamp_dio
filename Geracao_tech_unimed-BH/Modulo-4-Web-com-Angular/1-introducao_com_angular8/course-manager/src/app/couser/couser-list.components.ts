import { Component, OnInit } from "@angular/core";
import { Course } from "./course";
import { CourseService } from "./curse.service";

@Component({
    selector: 'app-course-list',
    // template: '<h2> Course List </h2>' 
    templateUrl: './couser-list.components.html' 
})
export class CourseListComponent implements OnInit {
    
    filteredCourses: Course[] = []

    _courses: Course[] = []
    
    _filterBy!: string


    constructor(private courseService: CourseService) {}

    ngOnInit(): void {
        this._courses = this.courseService.retriveAll()

        this.filteredCourses = this._courses

    }

    set filter(value: string){
        this._filterBy = value

        this.filteredCourses = this._courses.filter(
                (course: Course) => course.name.toLocaleLowerCase().indexOf(
                    this._filterBy.toLocaleLowerCase()
                ) > -1)
    }

    get filter(){
        return this._filterBy
    }
}