import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { LayoutComponent } from './layout/layout.component';
import { AddEmpComponent } from './add-emp/add-emp.component';
import { UpdateEmpComponent } from './update-emp/update-emp.component';
import { DeleteEmpComponent } from './delete-emp/delete-emp.component';
import { ListEmpComponent } from './list-emp/list-emp.component';
export const routes: Routes = [
    {path:'',redirectTo:'login',pathMatch:'full'},
    {path:'login',component:LoginComponent},
    {path:'',component:LayoutComponent,
        children:[
            {path:'add-emp',component: AddEmpComponent},
            {path:'update-emp',component: UpdateEmpComponent},
            {path:'delete-emp',component: DeleteEmpComponent},
            {path:'list-emp',component: ListEmpComponent}
        ]
    }
];
