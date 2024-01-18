﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {

        string json = @"
[
  {
    ""locale"": ""tr"",
    ""description"": ""TEŞEKKÜRLER\nGUNEYDOĞU TEKS. GIDA INS SAN. LTD.STI.\nORNEKTEPE MAH.ETIBANK CAD.SARAY APT.\nN:43-1 BEYOĞLU/ISTANBUL\nGÜNEŞLİ V.D.\n4350078928 V. NO.\nTARIH : 26.08.2020\nSAAT : 15:27\nFİŞ NO : 0082\n54491250\n2 ADx 2,75\nCC.COCA COLA CAM 200\n2701084\n1,566 KGx 1,99\nMANAV DOMATES PETEME\n08\n*5,50\n*3,32\n2701076\n0,358 KGx 4,99\nMANAV BIBER CARLISTO\n08\n*1,79\n4\nEKMEK CIFTLI\n01\n*1,25\nTOPKDV\nTOPLAM\n*0,80\n*11,86\nNAKİT\n*20,00\nKDV\n01\n08\nKDV TUTARI\n*0,01\n*0,79\nKDV'LI TOPLAM\n*1,25\n*10,61\nKASİYER : SUPERVISOR\n00 0001/020/000084/1//82/\nPARA USTÜ\n*8,14\nKASİYER: 1\n2 NO:1330\nEKÜ NO:0001\nMF YAB 15017876\n"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 35,
          ""y"": 88
        },
        {
          ""x"": 576,
          ""y"": 88
        },
        {
          ""x"": 576,
          ""y"": 1077
        },
        {
          ""x"": 35,
          ""y"": 1077
        }
      ]
    }
  },
  {
    ""description"": ""TEŞEKKÜRLER"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 36,
          ""y"": 88
        },
        {
          ""x"": 174,
          ""y"": 93
        },
        {
          ""x"": 173,
          ""y"": 114
        },
        {
          ""x"": 35,
          ""y"": 109
        }
      ]
    }
  },
  {
    ""description"": ""GUNEYDOĞU"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 36,
          ""y"": 114
        },
        {
          ""x"": 148,
          ""y"": 116
        },
        {
          ""x"": 148,
          ""y"": 138
        },
        {
          ""x"": 36,
          ""y"": 136
        }
      ]
    }
  },
  {
    ""description"": ""TEKS."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 165,
          ""y"": 120
        },
        {
          ""x"": 221,
          ""y"": 121
        },
        {
          ""x"": 221,
          ""y"": 139
        },
        {
          ""x"": 165,
          ""y"": 138
        }
      ]
    }
  },
  {
    ""description"": ""GIDA"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 242,
          ""y"": 116
        },
        {
          ""x"": 289,
          ""y"": 117
        },
        {
          ""x"": 289,
          ""y"": 140
        },
        {
          ""x"": 242,
          ""y"": 139
        }
      ]
    }
  },
  {
    ""description"": ""INS"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 307,
          ""y"": 122
        },
        {
          ""x"": 340,
          ""y"": 123
        },
        {
          ""x"": 340,
          ""y"": 141
        },
        {
          ""x"": 307,
          ""y"": 140
        }
      ]
    }
  },
  {
    ""description"": ""SAN."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 349,
          ""y"": 123
        },
        {
          ""x"": 399,
          ""y"": 124
        },
        {
          ""x"": 399,
          ""y"": 141
        },
        {
          ""x"": 349,
          ""y"": 140
        }
      ]
    }
  },
  {
    ""description"": ""LTD.STI."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 408,
          ""y"": 123
        },
        {
          ""x"": 502,
          ""y"": 125
        },
        {
          ""x"": 502,
          ""y"": 144
        },
        {
          ""x"": 408,
          ""y"": 142
        }
      ]
    }
  },
  {
    ""description"": ""ORNEKTEPE"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 49,
          ""y"": 142
        },
        {
          ""x"": 161,
          ""y"": 144
        },
        {
          ""x"": 161,
          ""y"": 163
        },
        {
          ""x"": 49,
          ""y"": 161
        }
      ]
    }
  },
  {
    ""description"": ""MAH.ETIBANK"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 178,
          ""y"": 147
        },
        {
          ""x"": 314,
          ""y"": 149
        },
        {
          ""x"": 314,
          ""y"": 166
        },
        {
          ""x"": 178,
          ""y"": 164
        }
      ]
    }
  },
  {
    ""description"": ""CAD.SARAY"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 331,
          ""y"": 148
        },
        {
          ""x"": 441,
          ""y"": 150
        },
        {
          ""x"": 441,
          ""y"": 168
        },
        {
          ""x"": 331,
          ""y"": 166
        }
      ]
    }
  },
  {
    ""description"": ""APT."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 458,
          ""y"": 149
        },
        {
          ""x"": 500,
          ""y"": 150
        },
        {
          ""x"": 500,
          ""y"": 168
        },
        {
          ""x"": 458,
          ""y"": 167
        }
      ]
    }
  },
  {
    ""description"": ""N:43-1"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 127,
          ""y"": 170
        },
        {
          ""x"": 196,
          ""y"": 171
        },
        {
          ""x"": 196,
          ""y"": 190
        },
        {
          ""x"": 127,
          ""y"": 189
        }
      ]
    }
  },
  {
    ""description"": ""BEYOĞLU/ISTANBUL"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 216,
          ""y"": 171
        },
        {
          ""x"": 415,
          ""y"": 174
        },
        {
          ""x"": 415,
          ""y"": 194
        },
        {
          ""x"": 216,
          ""y"": 191
        }
      ]
    }
  },
  {
    ""description"": ""GÜNEŞLİ"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 75,
          ""y"": 195
        },
        {
          ""x"": 161,
          ""y"": 197
        },
        {
          ""x"": 160,
          ""y"": 217
        },
        {
          ""x"": 74,
          ""y"": 215
        }
      ]
    }
  },
  {
    ""description"": ""V.D."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 178,
          ""y"": 198
        },
        {
          ""x"": 220,
          ""y"": 199
        },
        {
          ""x"": 220,
          ""y"": 216
        },
        {
          ""x"": 178,
          ""y"": 215
        }
      ]
    }
  },
  {
    ""description"": ""4350078928"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 266,
          ""y"": 199
        },
        {
          ""x"": 389,
          ""y"": 200
        },
        {
          ""x"": 389,
          ""y"": 218
        },
        {
          ""x"": 266,
          ""y"": 217
        }
      ]
    }
  },
  {
    ""description"": ""V."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 406,
          ""y"": 201
        },
        {
          ""x"": 423,
          ""y"": 201
        },
        {
          ""x"": 423,
          ""y"": 218
        },
        {
          ""x"": 406,
          ""y"": 218
        }
      ]
    }
  },
  {
    ""description"": ""NO."",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 431,
          ""y"": 201
        },
        {
          ""x"": 461,
          ""y"": 201
        },
        {
          ""x"": 461,
          ""y"": 219
        },
        {
          ""x"": 431,
          ""y"": 219
        }
      ]
    }
  },
  {
    ""description"": ""TARIH"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 50,
          ""y"": 247
        },
        {
          ""x"": 111,
          ""y"": 249
        },
        {
          ""x"": 111,
          ""y"": 266
        },
        {
          ""x"": 50,
          ""y"": 264
        }
      ]
    }
  },
  {
    ""description"": "":"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 142,
          ""y"": 247
        },
        {
          ""x"": 160,
          ""y"": 247
        },
        {
          ""x"": 159,
          ""y"": 270
        },
        {
          ""x"": 141,
          ""y"": 270
        }
      ]
    }
  },
  {
    ""description"": ""26.08.2020"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 165,
          ""y"": 249
        },
        {
          ""x"": 287,
          ""y"": 252
        },
        {
          ""x"": 286,
          ""y"": 271
        },
        {
          ""x"": 164,
          ""y"": 268
        }
      ]
    }
  },
  {
    ""description"": ""SAAT"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 50,
          ""y"": 272
        },
        {
          ""x"": 98,
          ""y"": 273
        },
        {
          ""x"": 97,
          ""y"": 290
        },
        {
          ""x"": 50,
          ""y"": 289
        }
      ]
    }
  },
  {
    ""description"": "":"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 145,
          ""y"": 272
        },
        {
          ""x"": 155,
          ""y"": 272
        },
        {
          ""x"": 154,
          ""y"": 296
        },
        {
          ""x"": 144,
          ""y"": 296
        }
      ]
    }
  },
  {
    ""description"": ""15:27"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 167,
          ""y"": 276
        },
        {
          ""x"": 224,
          ""y"": 278
        },
        {
          ""x"": 223,
          ""y"": 295
        },
        {
          ""x"": 167,
          ""y"": 293
        }
      ]
    }
  },
  {
    ""description"": ""FİŞ"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 41,
          ""y"": 294
        },
        {
          ""x"": 107,
          ""y"": 296
        },
        {
          ""x"": 106,
          ""y"": 323
        },
        {
          ""x"": 40,
          ""y"": 321
        }
      ]
    }
  },
  {
    ""description"": ""NO"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 110,
          ""y"": 296
        },
        {
          ""x"": 135,
          ""y"": 297
        },
        {
          ""x"": 134,
          ""y"": 324
        },
        {
          ""x"": 109,
          ""y"": 323
        }
      ]
    }
  },
  {
    ""description"": "":"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 142,
          ""y"": 297
        },
        {
          ""x"": 163,
          ""y"": 298
        },
        {
          ""x"": 162,
          ""y"": 325
        },
        {
          ""x"": 141,
          ""y"": 324
        }
      ]
    }
  },
  {
    ""description"": ""0082"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 166,
          ""y"": 301
        },
        {
          ""x"": 212,
          ""y"": 302
        },
        {
          ""x"": 212,
          ""y"": 320
        },
        {
          ""x"": 166,
          ""y"": 319
        }
      ]
    }
  },
  {
    ""description"": ""54491250"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 51,
          ""y"": 352
        },
        {
          ""x"": 149,
          ""y"": 354
        },
        {
          ""x"": 149,
          ""y"": 371
        },
        {
          ""x"": 51,
          ""y"": 369
        }
      ]
    }
  },
  {
    ""description"": ""2"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 39,
          ""y"": 375
        },
        {
          ""x"": 48,
          ""y"": 375
        },
        {
          ""x"": 48,
          ""y"": 392
        },
        {
          ""x"": 39,
          ""y"": 392
        }
      ]
    }
  },
  {
    ""description"": ""ADx"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 64,
          ""y"": 376
        },
        {
          ""x"": 100,
          ""y"": 377
        },
        {
          ""x"": 100,
          ""y"": 394
        },
        {
          ""x"": 64,
          ""y"": 393
        }
      ]
    }
  },
  {
    ""description"": ""2,75"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 115,
          ""y"": 377
        },
        {
          ""x"": 163,
          ""y"": 378
        },
        {
          ""x"": 162,
          ""y"": 402
        },
        {
          ""x"": 114,
          ""y"": 401
        }
      ]
    }
  },
  {
    ""description"": ""CC.COCA"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 39,
          ""y"": 401
        },
        {
          ""x"": 125,
          ""y"": 402
        },
        {
          ""x"": 125,
          ""y"": 423
        },
        {
          ""x"": 39,
          ""y"": 422
        }
      ]
    }
  },
  {
    ""description"": ""COLA"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 141,
          ""y"": 403
        },
        {
          ""x"": 187,
          ""y"": 404
        },
        {
          ""x"": 187,
          ""y"": 421
        },
        {
          ""x"": 141,
          ""y"": 420
        }
      ]
    }
  },
  {
    ""description"": ""CAM"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 203,
          ""y"": 404
        },
        {
          ""x"": 236,
          ""y"": 404
        },
        {
          ""x"": 236,
          ""y"": 420
        },
        {
          ""x"": 203,
          ""y"": 420
        }
      ]
    }
  },
  {
    ""description"": ""200"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 253,
          ""y"": 405
        },
        {
          ""x"": 286,
          ""y"": 405
        },
        {
          ""x"": 286,
          ""y"": 421
        },
        {
          ""x"": 253,
          ""y"": 421
        }
      ]
    }
  },
  {
    ""description"": ""2701084"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 52,
          ""y"": 426
        },
        {
          ""x"": 137,
          ""y"": 426
        },
        {
          ""x"": 137,
          ""y"": 443
        },
        {
          ""x"": 52,
          ""y"": 443
        }
      ]
    }
  },
  {
    ""description"": ""1,566"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 41,
          ""y"": 449
        },
        {
          ""x"": 99,
          ""y"": 450
        },
        {
          ""x"": 99,
          ""y"": 468
        },
        {
          ""x"": 41,
          ""y"": 467
        }
      ]
    }
  },
  {
    ""description"": ""KGx"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 116,
          ""y"": 451
        },
        {
          ""x"": 149,
          ""y"": 451
        },
        {
          ""x"": 149,
          ""y"": 467
        },
        {
          ""x"": 116,
          ""y"": 467
        }
      ]
    }
  },
  {
    ""description"": ""1,99"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 167,
          ""y"": 452
        },
        {
          ""x"": 211,
          ""y"": 452
        },
        {
          ""x"": 211,
          ""y"": 469
        },
        {
          ""x"": 167,
          ""y"": 469
        }
      ]
    }
  },
  {
    ""description"": ""MANAV"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 39,
          ""y"": 474
        },
        {
          ""x"": 99,
          ""y"": 475
        },
        {
          ""x"": 99,
          ""y"": 491
        },
        {
          ""x"": 39,
          ""y"": 490
        }
      ]
    }
  },
  {
    ""description"": ""DOMATES"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 116,
          ""y"": 475
        },
        {
          ""x"": 199,
          ""y"": 476
        },
        {
          ""x"": 199,
          ""y"": 492
        },
        {
          ""x"": 116,
          ""y"": 491
        }
      ]
    }
  },
  {
    ""description"": ""PETEME"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 215,
          ""y"": 476
        },
        {
          ""x"": 285,
          ""y"": 477
        },
        {
          ""x"": 285,
          ""y"": 493
        },
        {
          ""x"": 215,
          ""y"": 492
        }
      ]
    }
  },
  {
    ""description"": ""08"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 339,
          ""y"": 406
        },
        {
          ""x"": 372,
          ""y"": 406
        },
        {
          ""x"": 372,
          ""y"": 422
        },
        {
          ""x"": 339,
          ""y"": 422
        }
      ]
    }
  },
  {
    ""description"": ""*5,50"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 500,
          ""y"": 406
        },
        {
          ""x"": 558,
          ""y"": 406
        },
        {
          ""x"": 558,
          ""y"": 424
        },
        {
          ""x"": 500,
          ""y"": 424
        }
      ]
    }
  },
  {
    ""description"": ""*3,32"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 498,
          ""y"": 478
        },
        {
          ""x"": 556,
          ""y"": 478
        },
        {
          ""x"": 556,
          ""y"": 497
        },
        {
          ""x"": 498,
          ""y"": 497
        }
      ]
    }
  },
  {
    ""description"": ""2701076"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 53,
          ""y"": 501
        },
        {
          ""x"": 137,
          ""y"": 501
        },
        {
          ""x"": 137,
          ""y"": 517
        },
        {
          ""x"": 53,
          ""y"": 517
        }
      ]
    }
  },
  {
    ""description"": ""0,358"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 40,
          ""y"": 524
        },
        {
          ""x"": 100,
          ""y"": 524
        },
        {
          ""x"": 100,
          ""y"": 543
        },
        {
          ""x"": 40,
          ""y"": 543
        }
      ]
    }
  },
  {
    ""description"": ""KGx"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 116,
          ""y"": 525
        },
        {
          ""x"": 149,
          ""y"": 525
        },
        {
          ""x"": 149,
          ""y"": 541
        },
        {
          ""x"": 116,
          ""y"": 541
        }
      ]
    }
  },
  {
    ""description"": ""4,99"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 166,
          ""y"": 526
        },
        {
          ""x"": 211,
          ""y"": 526
        },
        {
          ""x"": 211,
          ""y"": 543
        },
        {
          ""x"": 166,
          ""y"": 543
        }
      ]
    }
  },
  {
    ""description"": ""MANAV"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 40,
          ""y"": 551
        },
        {
          ""x"": 100,
          ""y"": 552
        },
        {
          ""x"": 100,
          ""y"": 567
        },
        {
          ""x"": 40,
          ""y"": 566
        }
      ]
    }
  },
  {
    ""description"": ""BIBER"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 116,
          ""y"": 550
        },
        {
          ""x"": 174,
          ""y"": 551
        },
        {
          ""x"": 174,
          ""y"": 568
        },
        {
          ""x"": 116,
          ""y"": 567
        }
      ]
    }
  },
  {
    ""description"": ""CARLISTO"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 190,
          ""y"": 551
        },
        {
          ""x"": 284,
          ""y"": 552
        },
        {
          ""x"": 284,
          ""y"": 569
        },
        {
          ""x"": 190,
          ""y"": 568
        }
      ]
    }
  },
  {
    ""description"": ""08"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 336,
          ""y"": 554
        },
        {
          ""x"": 369,
          ""y"": 554
        },
        {
          ""x"": 369,
          ""y"": 570
        },
        {
          ""x"": 336,
          ""y"": 570
        }
      ]
    }
  },
  {
    ""description"": ""*1,79"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 496,
          ""y"": 555
        },
        {
          ""x"": 554,
          ""y"": 555
        },
        {
          ""x"": 554,
          ""y"": 573
        },
        {
          ""x"": 496,
          ""y"": 573
        }
      ]
    }
  },
  {
    ""description"": ""4"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 53,
          ""y"": 576
        },
        {
          ""x"": 61,
          ""y"": 576
        },
        {
          ""x"": 61,
          ""y"": 590
        },
        {
          ""x"": 53,
          ""y"": 590
        }
      ]
    }
  },
  {
    ""description"": ""EKMEK"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 40,
          ""y"": 599
        },
        {
          ""x"": 99,
          ""y"": 599
        },
        {
          ""x"": 99,
          ""y"": 615
        },
        {
          ""x"": 40,
          ""y"": 615
        }
      ]
    }
  },
  {
    ""description"": ""CIFTLI"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 116,
          ""y"": 600
        },
        {
          ""x"": 184,
          ""y"": 600
        },
        {
          ""x"": 184,
          ""y"": 615
        },
        {
          ""x"": 116,
          ""y"": 615
        }
      ]
    }
  },
  {
    ""description"": ""01"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 336,
          ""y"": 602
        },
        {
          ""x"": 365,
          ""y"": 602
        },
        {
          ""x"": 365,
          ""y"": 617
        },
        {
          ""x"": 336,
          ""y"": 617
        }
      ]
    }
  },
  {
    ""description"": ""*1,25"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 495,
          ""y"": 603
        },
        {
          ""x"": 552,
          ""y"": 603
        },
        {
          ""x"": 552,
          ""y"": 620
        },
        {
          ""x"": 495,
          ""y"": 620
        }
      ]
    }
  },
  {
    ""description"": ""TOPKDV"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 53,
          ""y"": 648
        },
        {
          ""x"": 124,
          ""y"": 647
        },
        {
          ""x"": 124,
          ""y"": 664
        },
        {
          ""x"": 53,
          ""y"": 665
        }
      ]
    }
  },
  {
    ""description"": ""TOPLAM"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 53,
          ""y"": 672
        },
        {
          ""x"": 124,
          ""y"": 673
        },
        {
          ""x"": 124,
          ""y"": 689
        },
        {
          ""x"": 53,
          ""y"": 688
        }
      ]
    }
  },
  {
    ""description"": ""*0,80"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 518,
          ""y"": 652
        },
        {
          ""x"": 576,
          ""y"": 651
        },
        {
          ""x"": 576,
          ""y"": 669
        },
        {
          ""x"": 518,
          ""y"": 670
        }
      ]
    }
  },
  {
    ""description"": ""*11,86"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 506,
          ""y"": 675
        },
        {
          ""x"": 576,
          ""y"": 677
        },
        {
          ""x"": 575,
          ""y"": 695
        },
        {
          ""x"": 505,
          ""y"": 693
        }
      ]
    }
  },
  {
    ""description"": ""NAKİT"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 65,
          ""y"": 720
        },
        {
          ""x"": 123,
          ""y"": 720
        },
        {
          ""x"": 123,
          ""y"": 736
        },
        {
          ""x"": 65,
          ""y"": 736
        }
      ]
    }
  },
  {
    ""description"": ""*20,00"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 481,
          ""y"": 722
        },
        {
          ""x"": 550,
          ""y"": 723
        },
        {
          ""x"": 550,
          ""y"": 742
        },
        {
          ""x"": 481,
          ""y"": 741
        }
      ]
    }
  },
  {
    ""description"": ""KDV"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 65,
          ""y"": 768
        },
        {
          ""x"": 98,
          ""y"": 768
        },
        {
          ""x"": 98,
          ""y"": 784
        },
        {
          ""x"": 65,
          ""y"": 784
        }
      ]
    }
  },
  {
    ""description"": ""01"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 64,
          ""y"": 792
        },
        {
          ""x"": 94,
          ""y"": 792
        },
        {
          ""x"": 94,
          ""y"": 808
        },
        {
          ""x"": 64,
          ""y"": 808
        }
      ]
    }
  },
  {
    ""description"": ""08"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 64,
          ""y"": 816
        },
        {
          ""x"": 97,
          ""y"": 816
        },
        {
          ""x"": 97,
          ""y"": 832
        },
        {
          ""x"": 64,
          ""y"": 832
        }
      ]
    }
  },
  {
    ""description"": ""KDV"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 163,
          ""y"": 769
        },
        {
          ""x"": 196,
          ""y"": 769
        },
        {
          ""x"": 196,
          ""y"": 784
        },
        {
          ""x"": 163,
          ""y"": 784
        }
      ]
    }
  },
  {
    ""description"": ""TUTARI"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 212,
          ""y"": 769
        },
        {
          ""x"": 280,
          ""y"": 769
        },
        {
          ""x"": 280,
          ""y"": 784
        },
        {
          ""x"": 212,
          ""y"": 784
        }
      ]
    }
  },
  {
    ""description"": ""*0,01"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 224,
          ""y"": 792
        },
        {
          ""x"": 277,
          ""y"": 791
        },
        {
          ""x"": 277,
          ""y"": 808
        },
        {
          ""x"": 224,
          ""y"": 809
        }
      ]
    }
  },
  {
    ""description"": ""*0,79"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 224,
          ""y"": 816
        },
        {
          ""x"": 280,
          ""y"": 815
        },
        {
          ""x"": 280,
          ""y"": 832
        },
        {
          ""x"": 224,
          ""y"": 833
        }
      ]
    }
  },
  {
    ""description"": ""KDV'LI"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 322,
          ""y"": 770
        },
        {
          ""x"": 389,
          ""y"": 770
        },
        {
          ""x"": 389,
          ""y"": 785
        },
        {
          ""x"": 322,
          ""y"": 785
        }
      ]
    }
  },
  {
    ""description"": ""TOPLAM"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 407,
          ""y"": 770
        },
        {
          ""x"": 476,
          ""y"": 770
        },
        {
          ""x"": 476,
          ""y"": 786
        },
        {
          ""x"": 407,
          ""y"": 786
        }
      ]
    }
  },
  {
    ""description"": ""*1,25"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 419,
          ""y"": 794
        },
        {
          ""x"": 475,
          ""y"": 795
        },
        {
          ""x"": 475,
          ""y"": 811
        },
        {
          ""x"": 419,
          ""y"": 810
        }
      ]
    }
  },
  {
    ""description"": ""*10,61"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 406,
          ""y"": 818
        },
        {
          ""x"": 471,
          ""y"": 818
        },
        {
          ""x"": 471,
          ""y"": 834
        },
        {
          ""x"": 406,
          ""y"": 834
        }
      ]
    }
  },
  {
    ""description"": ""KASİYER"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 64,
          ""y"": 863
        },
        {
          ""x"": 146,
          ""y"": 863
        },
        {
          ""x"": 146,
          ""y"": 880
        },
        {
          ""x"": 64,
          ""y"": 880
        }
      ]
    }
  },
  {
    ""description"": "":"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 164,
          ""y"": 862
        },
        {
          ""x"": 173,
          ""y"": 862
        },
        {
          ""x"": 173,
          ""y"": 881
        },
        {
          ""x"": 164,
          ""y"": 881
        }
      ]
    }
  },
  {
    ""description"": ""SUPERVISOR"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 186,
          ""y"": 863
        },
        {
          ""x"": 304,
          ""y"": 864
        },
        {
          ""x"": 304,
          ""y"": 881
        },
        {
          ""x"": 186,
          ""y"": 880
        }
      ]
    }
  },
  {
    ""description"": ""00"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 60,
          ""y"": 909
        },
        {
          ""x"": 93,
          ""y"": 909
        },
        {
          ""x"": 93,
          ""y"": 932
        },
        {
          ""x"": 60,
          ""y"": 932
        }
      ]
    }
  },
  {
    ""description"": ""0001/020/000084/1//82/"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 95,
          ""y"": 909
        },
        {
          ""x"": 353,
          ""y"": 909
        },
        {
          ""x"": 353,
          ""y"": 932
        },
        {
          ""x"": 95,
          ""y"": 932
        }
      ]
    }
  },
  {
    ""description"": ""PARA"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 62,
          ""y"": 936
        },
        {
          ""x"": 108,
          ""y"": 936
        },
        {
          ""x"": 108,
          ""y"": 952
        },
        {
          ""x"": 62,
          ""y"": 952
        }
      ]
    }
  },
  {
    ""description"": ""USTÜ"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 124,
          ""y"": 936
        },
        {
          ""x"": 169,
          ""y"": 936
        },
        {
          ""x"": 169,
          ""y"": 952
        },
        {
          ""x"": 124,
          ""y"": 952
        }
      ]
    }
  },
  {
    ""description"": ""*8,14"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 490,
          ""y"": 941
        },
        {
          ""x"": 546,
          ""y"": 940
        },
        {
          ""x"": 546,
          ""y"": 957
        },
        {
          ""x"": 490,
          ""y"": 958
        }
      ]
    }
  },
  {
    ""description"": ""KASİYER:"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 61,
          ""y"": 1010
        },
        {
          ""x"": 152,
          ""y"": 1009
        },
        {
          ""x"": 152,
          ""y"": 1026
        },
        {
          ""x"": 61,
          ""y"": 1027
        }
      ]
    }
  },
  {
    ""description"": ""1"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 174,
          ""y"": 1011
        },
        {
          ""x"": 176,
          ""y"": 1011
        },
        {
          ""x"": 176,
          ""y"": 1025
        },
        {
          ""x"": 174,
          ""y"": 1025
        }
      ]
    }
  },
  {
    ""description"": ""2"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 73,
          ""y"": 1032
        },
        {
          ""x"": 88,
          ""y"": 1032
        },
        {
          ""x"": 88,
          ""y"": 1053
        },
        {
          ""x"": 73,
          ""y"": 1053
        }
      ]
    }
  },
  {
    ""description"": ""NO:1330"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 86,
          ""y"": 1034
        },
        {
          ""x"": 168,
          ""y"": 1034
        },
        {
          ""x"": 168,
          ""y"": 1051
        },
        {
          ""x"": 86,
          ""y"": 1051
        }
      ]
    }
  },
  {
    ""description"": ""EKÜ"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 416,
          ""y"": 1033
        },
        {
          ""x"": 477,
          ""y"": 1034
        },
        {
          ""x"": 477,
          ""y"": 1056
        },
        {
          ""x"": 416,
          ""y"": 1055
        }
      ]
    }
  },
  {
    ""description"": ""NO:0001"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 477,
          ""y"": 1038
        },
        {
          ""x"": 555,
          ""y"": 1040
        },
        {
          ""x"": 555,
          ""y"": 1056
        },
        {
          ""x"": 477,
          ""y"": 1054
        }
      ]
    }
  },
  {
    ""description"": ""MF"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 171,
          ""y"": 1061
        },
        {
          ""x"": 198,
          ""y"": 1061
        },
        {
          ""x"": 198,
          ""y"": 1075
        },
        {
          ""x"": 171,
          ""y"": 1075
        }
      ]
    }
  },
  {
    ""description"": ""YAB"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 212,
          ""y"": 1061
        },
        {
          ""x"": 244,
          ""y"": 1061
        },
        {
          ""x"": 244,
          ""y"": 1076
        },
        {
          ""x"": 212,
          ""y"": 1076
        }
      ]
    }
  },
  {
    ""description"": ""15017876"",
    ""boundingPoly"": {
      ""vertices"": [
        {
          ""x"": 262,
          ""y"": 1061
        },
        {
          ""x"": 354,
          ""y"": 1062
        },
        {
          ""x"": 354,
          ""y"": 1077
        },
        {
          ""x"": 262,
          ""y"": 1076
        }
      ]
    }
  }
]
";


        List<FişVerisi> fişVerisiListesi = JsonConvert.DeserializeObject<List<FişVerisi>>(json);


        var çıktıSatırları = new List<string>();

        foreach (var fişVerisi in fişVerisiListesi)
        {
  
            if (!string.IsNullOrEmpty(fişVerisi.Description))
            {
                çıktıSatırları.Add(fişVerisi.Description);
            }

            if (fişVerisi.BoundingPoly != null && fişVerisi.BoundingPoly.Vertices != null)
            {
                var vertices = fişVerisi.BoundingPoly.Vertices;
                çıktıSatırları.Add($"{vertices[0].X} {vertices[0].Y}");
                çıktıSatırları.Add($"{vertices[1].X} {vertices[1].Y}");
                çıktıSatırları.Add($"{vertices[2].X} {vertices[2].Y}");
                çıktıSatırları.Add($"{vertices[3].X} {vertices[3].Y}");
            }
        }

        string çıktı = string.Join("\n", çıktıSatırları);
        Console.WriteLine(çıktı);




    }
}

public class FişVerisi
{
    public string Locale { get; set; }
    public string Description { get; set; }
    public BoundingPoly BoundingPoly { get; set; }



}


public class BoundingPoly
{
    public List<IkizKenar> Vertices { get; set; }
}

public class IkizKenar
{
    public int X { get; set; }
    public int Y { get; set; }
}
