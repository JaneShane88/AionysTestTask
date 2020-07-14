import { Component, AfterViewInit } from '@angular/core';
import { NoteService } from '../../services/note.service';
import { NoteDTO } from '../../models/note.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-note',
  templateUrl: './edit-note.component.html',
  styleUrls: ['./edit-note.component.sass']
})
export class EditNoteComponent implements AfterViewInit {
  
  // @Input() public note: NoteDTO = new NoteDTO();
  note: NoteDTO = new NoteDTO();

  constructor(
    private NoteService: NoteService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngAfterViewInit() {
    this.route.params.subscribe (params => this.note.id = params['id']);
    this.note.id = this.route.snapshot.params["id"];
    this.getNote();
  }

  getNote() {
    this.NoteService.getNote(this.note.id).subscribe((data: NoteDTO) => {
      this.note = data;
    })
  }

  save() {
    this.NoteService.putNote(this.note).subscribe((data: NoteDTO) => {  
    this.note = new NoteDTO();
    this.cancel()})
  }
  
  cancel() {
    this.router.navigate(['/notes']);
  }
}
