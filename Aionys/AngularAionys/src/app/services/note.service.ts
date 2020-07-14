import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NoteDTO } from '../models/note.model';
import { Injectable } from '@angular/core';
import {map} from 'rxjs/operators';

@Injectable()
export class NoteService {
    url = environment.apiUrl + '/note';

    constructor(private http: HttpClient) {}

    getNotes(): Observable<NoteDTO[]> {
        return this.http.get<NoteDTO[]>(this.url)
    };

    getNote(id: number): Observable<NoteDTO> {
        return this.http.get<NoteDTO>(`${this.url}/${id}`);
    }

    postNote(note: NoteDTO) {
        return this.http.post(this.url, note);
    }

    putNote(note: NoteDTO) {
        return this.http.put(this.url, note);
    }

    deleteNote(id: number) {
        return this.http.delete(`${this.url}/${id}`);
    }
}