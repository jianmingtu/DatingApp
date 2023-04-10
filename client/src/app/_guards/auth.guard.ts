import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable, map } from 'rxjs';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private accountServer: AccountService, private toastr: ToastrService) {

  }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean>  {
      
      return this.accountServer.currentUser$.pipe(
        map( user =>{
          if(user)
            return true;
          else {
            this.toastr.error('you shal not pass pass!');
            return false;
          }
        })
      );
  }
  
}
