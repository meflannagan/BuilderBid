import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { AuthGuard } from './_guards/auth.guard';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberDetailResolver } from './_resolvers/member-detail.resolver';
import { MemberListResolver } from './_resolvers/member-list.resolver';
import { AboutusComponent } from './aboutus/aboutus/aboutus.component';
import { ContactComponent } from './contact/contact.component';

export const appRoutes: Routes =[
    { path: '', component: HomeComponent},
    { path: 'about', component: AboutusComponent},
    { path: 'contact', component: ContactComponent},
    { 
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'contracts', component: MemberListComponent, resolve: {users: MemberListResolver}},
            { path: 'messages', component: MessagesComponent},
            { path: 'lists', component: MemberListComponent, resolve: {users: MemberListResolver}},
            { path: 'lists/:id', component: MemberDetailComponent, resolve: {user: MemberDetailResolver}},
            
        ]
    },
    
    
    { path: '**', redirectTo: '', pathMatch: 'full'}
]