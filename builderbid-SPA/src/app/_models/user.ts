import {Photo} from './photo';
import {Bid} from './bid';
import {Contract} from './contract';

export interface User {
    id: number;
    username: string;
    company: string;
    city: string;
    state: string;
    zipcode: string;
    photoUrl: string;
    photos?: Photo[];
    bids?: Bid[];
    contracts: Contract[];
}
