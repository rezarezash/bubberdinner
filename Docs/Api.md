# BubberDinner API

### Register Request
```js
POST {{host}}/auth/register
```
```json
  {
  "firstName": "",
  "lastName": "",
  "email": "",
  "password": ""
  }
```
### Register Response
```js
200 Ok
```
```json
  {
  "id": "",
  "firstName": "",
  "lastName": "",
  "token": ""
  }
```

### Login Request
```js
POST {{host}}/auth/login
```
```json
 {
  "email": "",
  "password": ""
 }
```

### Login Response
```js
200 Ok
```
```json
 {
  "id": "",
  "firstName": "",
  "lastName": "",
  "token": ""
 }
```


