import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Component } from '@angular/core';
import {FormsModule} from '@angular/forms'
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component'
import { CalculatorComponent } from './calculator/calculator.component';
import { LoginComponent } from './login/login.component'
import { ClickRenderComponent } from './click-render/click-render.component';
import { StudentsComponent } from './students/students.component';
import { StudentsAComponent } from './students-a/students-a.component';
import { ReactiveFormsComponent } from './reactive-forms/reactive-forms.component';
import { ReactiveformsvalidationsComponent } from './reactiveformsvalidations/reactiveformsvalidations.component';
import { MovielibraryComponent } from './movielibrary/movielibrary.component';
const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'calculator', component: CalculatorComponent },
  { path: 'login', component: LoginComponent },
  { path: 'click-render', component: ClickRenderComponent },
  { path: 'students', component: StudentsComponent },
  { path: 'students-a', component: StudentsAComponent },
  { path: 'reactive-forms', component: ReactiveFormsComponent },
  { path: 'reactiveformsvalidations', component: ReactiveformsvalidationsComponent },
  { path: 'movielibrary', component: MovielibraryComponent },




];




@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  
 }
