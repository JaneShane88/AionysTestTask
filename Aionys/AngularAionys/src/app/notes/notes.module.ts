import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotesComponent } from './notes.component';
import { NoteService } from '../services/note.service';
import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';
import { MatMenuModule } from '@angular/material/menu';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatIconModule} from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import { EditNoteComponent } from './edit-note/edit-note.component';
import { AddNoteComponent } from './add-note/add-note.component';
import { ShowNoteComponent } from './show-note/show-note.component';

@NgModule({
  declarations: [NotesComponent, EditNoteComponent, AddNoteComponent, ShowNoteComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    MatTableModule,
    MatMenuModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatIconModule,
    FormsModule,
    MatButtonModule,
    MatInputModule
  ],
  entryComponents: [AddNoteComponent],
  providers: [NoteService]
})
export class NotesModule { }
