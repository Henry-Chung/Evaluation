import { Income } from './income';
import { Expenditure } from './expenditure';
export interface User {
  id: number;
  email: string;
  password: string;
  fullname: string;
  joinedOn?: any;
  incomes: Income[];
  expenditures: Expenditure[];
}
