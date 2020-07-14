import { Component,  AfterViewInit  } from '@angular/core';
import { NoteService } from '../../services/note.service';
import { NoteDTO } from '../../models/note.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-show-note',
  templateUrl: './show-note.component.html',
  styleUrls: ['./show-note.component.sass']
})
export class ShowNoteComponent implements AfterViewInit {

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
  
  cancel() {
    this.router.navigate(['/notes']);
  }

}
