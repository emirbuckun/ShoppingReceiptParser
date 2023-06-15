# Shopping Receipt Parser

> A receipt scanning system will be developed. A SaaS system is used for the OCR phase.

**System Description:** A json response is returned from the SaaS service for each receipt image. In the json response, there is the coordinate information for the description and the related description. The aim is to parse the json appropriately and save the text of the receipt as close as it appears in the image.

> **Shopping Receipt Parser** parses the response json data to output txt file.

## Example Image

![image](https://github.com/emirbuckun/ShoppingReceiptParser/assets/63044078/828436db-980b-47db-b787-c0cf546c7f8e)


## Run

Clone the project

```bash

git clone https://github.com/emirbuckun/ShoppingReceiptParser/.git

```

Go to the project folder

```bash

cd ShoppingReceiptParser

```

Run the program

```bash

dotnet run

```
