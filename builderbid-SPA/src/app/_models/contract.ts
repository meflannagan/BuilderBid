import { Photo } from './photo';

export interface Contract {
    id: number;
    category: string;
    company: string;
    city: string;
    state: string;
    zipcode: string;
    startDate: Date;
    endDate: Date;
    startBid: number;
    winningBid: number;
    photos?: Photo[];
}
