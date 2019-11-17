import { Injectable } from "@angular/core";
import {Resolve, Router, ActivatedRouteSnapshot} from "@angular/router";
import {User} from "../_models/user";
import { AlertifyService } from '../services/alertify.service';
import { UserService } from '../services/user.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';



@Injectable()
export class MemberDetailResolver implements Resolve<User> {
    constructor(private userService: UserService, 
        private router: Router, private alertify: AlertifyService){}

    resolve(route: ActivatedRouteSnapshot): Observable<User> {
        return this.userService.getUser(route.params['id']).pipe(
            catchError(error => {
                this.alertify.error('Problem retrieving data');
                this.router.navigate(['/lists']);
                return of(null);
            })
        )
    }
}