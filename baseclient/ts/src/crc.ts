
import { Uint64BE } from 'int64-buffer'
const POLY = [0xc9, 0x6c,0x57, 0x95, 0xd7, 0x87,0x0f, 0x42];
const EMPTY = [0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00];
const crcTable:any[][] = [
  [],[],[],[],[],[],[],[]
];

for (let n = 0; n < 256; n++) {
  let crc = n;
  let table = crc & 1 ? POLY.concat() : EMPTY.concat();
  table[7] = table[7] ^ (crc >> 1);
  for (let k = 0; k < 7; k++){
    crc = table[7];
    for(let i = table.length - 1;i >= 0 ;i--) {
      table[i] = table[i - 1] & 1 ? (table[i] >> 1) ^ 128 : table[i] >> 1;
      table[i] = crc & 1 ? POLY[i] ^ table[i] : table[i]; 
    }
  }
  crcTable[0][n] = table;
}

for (let n = 0; n < 256; n++) {
  let crc = crcTable[0][n];
  for (let k = 1; k < 8; k++) {
    let tmp = [];
    let arr = crcTable[0][crc[7]];
    tmp[0] = arr[0] ^ 0x00;
    for(let i = 1;i < arr.length; i++){
      tmp[i] = arr[i] ^ (crc[i - 1]);
    }
    crcTable[k][n] = tmp;
    crc = tmp;
  }
}

export default class Crc64 {

  _crc: any

  constructor() {
    this._crc = [0xff,0xff,0xff,0xff,0xff,0xff,0xff,0xff];
  }

  update(buf: Buffer){
    
    let length = buf.length;
    let i = 0;
    for (; i < buf.length - 7; i += 8) {
      for(let j = 0;j < this._crc.length; j++){
        this._crc[j] = this._crc[j] ^ buf[i + 7 - j];
      }
      let tmp = [];
      for(let j = 0;j < this._crc.length; j++){
        let crc = 0;
        for (let k = 7; k >= 0; k--) {
          crc ^= crcTable[k][this._crc[k]][j];
        }
        tmp[j] = crc;
      }
      this._crc = tmp;
    }
    for(; i < buf.length; i++){
      let tmp = [];
      let arr = crcTable[0][this._crc[7] ^ buf[i]];
      tmp[0] = arr[0] ^ 0x00;
      for(let i = 1;i < arr.length; i++){
        tmp[i] = arr[i] ^ (this._crc[i - 1]);
      }
      this._crc = tmp;
    }
  }

  sum(): string {
    for (let i = 0; i < this._crc.length; i++) { 
      this._crc[i] = this._crc[i] ^ 0xFF;
    }
    
    let big = new Uint64BE(this._crc);
    return big.toString(10);
  }
}