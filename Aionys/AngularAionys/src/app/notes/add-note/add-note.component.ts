import { Component, OnInit } from '@angular/core';
import { NoteService } from '../../services/note.service';
import { NoteDTO } from '../../models/note.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.sass']
})
export class AddNoteComponent implements OnInit {
  
  note: NoteDTO = new NoteDTO();
  
  constructor(
    private NoteService: NoteService,
    private route: Router) { }

  ngOnInit(): void {
  }

  save() {
    this.NoteService.postNote(this.note).subscribe((data: NoteDTO) => {  
    this.note = new NoteDTO();
    this.cancel()})
  }
  
  cancel() {
    this.route.navigate(['/notes']);
  }
}
