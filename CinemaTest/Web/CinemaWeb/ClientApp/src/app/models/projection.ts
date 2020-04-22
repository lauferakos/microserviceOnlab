import { Film } from "./film";

export interface Projection{
  _id:number,
  film: Film,
  room: number,
  freeseats: number
  startTime: string

}
