import { Attendee } from './Attendee';

export class Meeting {
  id: number;
  date: Date;
  name: string;
  attendees: Attendee[];
}   
