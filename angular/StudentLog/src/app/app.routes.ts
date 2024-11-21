import { Routes } from '@angular/router';
import { StudentsComponent } from './Pages/students/students.component';
import { AddNewComponent } from './Pages/add-new/add-new.component';
import { ListComponent } from './Pages/list/list.component';
import { DetailsComponent } from './Pages/details/details.component';
import { UpdateComponent } from './Pages/update/update.component';
import { DeleteComponent} from './Pages/delete/delete.component';
export const routes: Routes = 
[
    // {path:"",redirectTo:"Stud",pathMatch:"full"},
    {path: "Stud", component:StudentsComponent},
    {path:"Add", component: AddNewComponent},
    {path: "List", component: ListComponent},
    {path: "Details",component:DetailsComponent},
    {path: "Delete",component:DeleteComponent},
    {path:"Upd",component:UpdateComponent},

    {path: "Details/:Id",component:DetailsComponent},
    {path: "Upd/:Id",component:UpdateComponent},
    {path: "Delete/:Id",component:DeleteComponent}



];
