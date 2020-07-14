import { Component, OnInit, ViewChild} from '@angular/core';
import { NoteService } from '../services/note.service';
import { NoteDTO } from '../models/note.model';
import {Router } from '@angular/router';
import { EditNoteComponent } from './edit-note/edit-note.component';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.sass']
})
export class NotesComponent implements OnInit {
  
  notes: NoteDTO[];
  note: NoteDTO = new NoteDTO();
  tableMode: boolean = true;
  displayedColumns: string[] = ['id', 'text', 'date', 'menu'];

  constructor(
    private NoteService: NoteService,
    private route: Router) {
    }

  ngOnInit() {
    this.loadNotes();
  }

  loadNotes() {
    this.NoteService.getNotes().subscribe((data: NoteDTO[]) =>
      this.notes = data);
  }

  deleteNote(note: NoteDTO) {
    this.NoteService.deleteNote(note.id)
    .subscribe(data => this.loadNotes());
  }

  addNote() {
    this.route.navigate(['/add']);
  }

  editNote(note: NoteDTO) {
    this.route.navigate([`/edit/${note.id}`]);
  }

  showNote(note: NoteDTO) {
    this.route.navigate([`/note/${note.id}`]);
  }
}
