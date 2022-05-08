export interface Product {
  Id: number;
  Name: string;
  Description: string;
  Price: number;
  QuantityInStock: number;
  PictureUrl: string;
  Type: string;
  Brand: string;
}

export interface FetchResult<TData = any, TError = Error> {
  data?: TData;
  loading: boolean | null;
  error?: TError;
}
