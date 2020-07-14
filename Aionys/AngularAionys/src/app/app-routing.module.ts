import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NotesComponent} from './notes/notes.component';
import { AddNoteComponent } from './notes/add-note/add-note.component';
import { EditNoteComponent } from './notes/edit-note/edit-note.component';
import { ShowNoteComponent } from './notes/show-note/show-note.component';

const routes: Routes = [
  { path: 'notes', component: NotesComponent },
  { path: 'note/:id', component: ShowNoteComponent},
  { path: 'add', component: AddNoteComponent },
  { path: 'edit/:id', component: EditNoteComponent },
  { path: '', redirectTo: '/notes', pathMatch: 'full' },
  { path: '*', redirectTo: '/notes', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
