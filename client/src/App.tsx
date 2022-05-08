import { Key, useEffect, useState } from "react";
import axios from "axios";
import { Product, FetchResult } from "./type";
import Card from "@mui/material/Card";
import CardMedia from "@mui/material/CardMedia";
import CardContent from "@mui/material/CardContent";
import Typography from "@mui/material/Typography";
import OData from "react-odata";

function App() {
  // const [products, setProduct] = useState<Product[]>([]);

  const baseUrl = "https://localhost:7087/Products";
  const query = { select: ["id", "name", "description", "pictureUrl"] };

  // useEffect(() => {
  //   axios.get("https://localhost:7087/Products").then((res) => {
  //     const products = res.data;
  //     setProduct(products);
  //   });
  // }, []);

  return (
    <OData baseUrl={baseUrl} query={query}>
      {({ loading, error, data }: FetchResult) => (
        <>
          {loading && <p>Loading...</p>}
          {error && <p>error...</p>}
          {data &&
            data.value.map((item: Product, index: Key) => (
              <ul key={index}>
                <Card sx={{ maxWidth: 345, m: 5 }}>
                  <CardMedia
                    component="img"
                    height="200"
                    image={item.PictureUrl}
                    alt={item.Name}
                  />
                  <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                      {item.Name}
                    </Typography>
                    <Typography variant="body2" color="text.secondary">
                      {item.Description}
                    </Typography>
                  </CardContent>
                </Card>
              </ul>
            ))}
        </>
      )}
    </OData>
  );
}

export default App;
