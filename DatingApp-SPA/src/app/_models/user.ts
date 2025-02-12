import { Photo } from './photo';

export interface User {
    id: number;
    user: string;
    knownAs: string;
    age: number;
    gemder: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
