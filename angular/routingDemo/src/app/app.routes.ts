import { Routes } from '@angular/router';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';
//import { Component } from '@angular/core';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { Component } from '@angular/core';
import { ChildAComponent } from './first/child-a/child-a.component';
import { ChildBComponent } from './first/child-b/child-b.component';


export const routes: Routes = 
[
    //{path : '' , redirectTo:'/first-component',pathMatch:"full"},
    //first component
    {path :"first-component" , component : FirstComponent,
children: [
    {
        path :'',redirectTo : 'child-a', pathMatch :'full'
    },
    {
        path : 'child-a' , component : ChildAComponent,
    },
    {
        path:'child-b' , component : ChildBComponent,
    },],
},
//second component
{path :"second-component", component : SecondComponent},
//page not found component
{path : "**", component : PageNotFoundComponent}
];
