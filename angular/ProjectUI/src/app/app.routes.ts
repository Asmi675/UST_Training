import { Routes } from '@angular/router';
import { ListComponent } from './Pages/list/list.component';
import { UpdateComponent } from './update/update.component';
import { DeleteComponent } from './Pages/delete/delete.component';
import { CreateComponent } from './Pages/create/create.component';
import { UserHomePageComponent } from './Pages/user page/user-home-page/user-home-page.component';
import { UserTutorPageComponent } from './Pages/user page/user-tutor-page/user-tutor-page.component';
import { UserPlumberPageComponent } from './Pages/user page/user-plumber-page/user-plumber-page.component';
import { UserElectricianPageComponent } from './Pages/user page/user-electrician-page/user-electrician-page.component';

export const routes: Routes = 
[
    {path: "List", component: ListComponent},
    {path: "update", component: UpdateComponent},
    {path: "delete", component: DeleteComponent},
    {path: "create", component: CreateComponent},
    {path:"user", component: UserHomePageComponent},
    {path :"tutor",component: UserTutorPageComponent},
    {path:"plumber",component:UserPlumberPageComponent},
    {path:"electrician",component:UserElectricianPageComponent}

];
