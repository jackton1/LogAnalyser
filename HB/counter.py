import json

from collections import Counter
data=['0:08',
'0:08',
'0:08',
'0:08',
'0:18',
'0:18',
'0:18',
'0:18',
'0:27',
'0:27',
'0:27',
'0:27',
'0:36',
'0:36',
'0:36',
'0:36',
'0:45',
'0:45',
'0:45',
'0:45',
'0:55',
'0:55',
'0:55',
'0:55',
'1:04',
'1:04',
'1:04',
'1:13',
'1:13',
'1:13',
'1:22',
'1:22',
'1:22',
'1:22',
'1:32',
'1:32',
'1:32',
'1:32',
'1:41',
'1:41',
'1:41',
'1:41',
'1:50',
'1:50',
'1:50',
'1:50',
'1:59',
'1:59',
'1:59',
'1:59',
'2:09',
'2:09',
'2:09',
'2:09',
'2:18',
'2:18',
'2:18',
'2:18',
'2:27',
'2:27',
'2:27',
'2:27',
'2:36',
'2:36',
'2:36',
'2:46',
'2:46',
'2:46',
'2:46',
'2:55',
'2:55',
'2:55',
'2:55',
'3:04',
'3:04',
'3:04',
'3:04',
'3:13',
'3:13',
'3:13',
'3:13',
'3:22',
'3:22',
'3:22',
'3:22',
'3:32',
'3:32',
'3:32',
'3:32',
'3:41',
'3:41',
'3:41',
'3:41',
'3:50',
'3:50',
'3:50',
'3:50',
'3:59',
'3:59',
'3:59',
'3:59',
'4:09',
'4:09',
'4:09',
'4:09',
'4:18',
'4:18',
'4:18',
'4:18',
'4:27',
'4:27',
'4:27',
'4:27',
'4:36',
'4:36',
'4:36',
'4:36',
'4:46',
'4:46',
'4:46',
'4:46',
'4:55',
'4:55',
'4:55',
'5:04',
'5:04',
'5:04',
'5:04',
'5:13',
'5:13',
'5:13',
'5:13',
'5:23',
'5:23',
'5:23',
'5:23',
'5:32',
'5:32',
'5:32',
'5:32',
'5:41',
'5:41',
'5:41',
'5:41',
'5:50',
'5:50',
'5:50',
'5:50',
'5:59',
'5:59',
'5:59',
'5:59',
'6:09',
'6:09',
'6:09',
'6:09',
'6:18',
'6:18',
'6:18',
'6:18',
'6:27',
'6:27',
'6:27',
'6:27',
'6:36',
'6:36',
'6:36',
'6:36',
'6:46',
'6:46',
'6:46',
'6:46',
'6:55',
'6:55',
'6:55',
'6:55',
'7:04',
'7:04',
'7:04',
'7:04',
'7:13',
'7:13',
'7:13',
'7:13',
'7:23',
'7:23',
'7:23',
'7:23',
'7:32',
'7:32',
'7:32',
'7:32',
'7:41',
'7:41',
'7:41',
'7:41',
'7:50',
'7:50',
'7:50',
'7:59',
'7:59',
'7:59',
'7:59',
'8:09',
'8:09',
'8:09',
'8:09',
'8:18',
'8:18',
'8:18',
'8:27',
'8:27',
'8:27',
'8:27',
'8:36',
'8:36',
'8:36',
'8:36',
'8:46',
'8:46',
'8:46',
'8:46',
'8:55',
'8:55',
'8:55',
'8:55',
'9:04',
'9:04',
'9:04',
'9:04',
'9:13',
'9:13',
'9:13',
'9:13',
'9:23',
'9:23',
'9:23',
'9:23',
'9:32',
'9:32',
'9:32',
'9:32',
'9:41',
'9:41',
'9:41',
'9:41',
'9:50',
'9:50',
'9:50',
'9:50',
'10:00',
'10:00',
'10:00',
'10:00',
'10:09',
'10:18',
'10:18',
'10:18',
'10:18',
'10:27',
'10:27',
'10:27',
'10:27',
'10:37',
'10:37',
'10:37',
'10:37',
'10:46',
'10:46',
'10:46',
'10:46',
'10:55',
'10:55',
'10:55',
'10:55',
'11:04',
'11:04',
'11:04',
'11:04',
'11:13',
'11:13',
'11:13',
'11:13',
'11:23',
'11:23',
'11:23',
'11:23',
'11:32',
'11:32',
'11:32',
'11:32',
'11:41',
'11:41',
'11:41',
'11:41',
'11:50',
'11:50',
'11:50',
'11:50',
'12:00',
'12:00',
'12:00',
'12:00',
'12:09',
'12:09',
'12:09',
'12:09',
'12:18',
'12:18',
'12:18',
'12:18',
'12:27',
'12:27',
'12:27',
'12:27',
'12:37',
'12:37',
'12:37',
'12:37',
'12:46',
'12:46',
'12:46',
'12:46',
'12:55',
'12:55',
'12:55',
'12:55',
'13:04',
'13:04',
'13:04',
'13:04',
'13:14',
'13:14',
'13:14',
'13:14',
'13:23',
'13:23',
'13:23',
'13:23',
'13:32',
'13:32',
'13:32',
'13:32',
'13:41',
'13:41',
'13:41',
'13:41',
'13:50',
'13:50',
'13:50',
'14:00',
'14:00',
'14:00',
'14:00',
'14:09',
'14:09',
'14:09',
'14:09',
'14:18',
'14:18',
'14:18',
'14:18',
'14:27',
'14:27',
'14:27',
'14:27',
'14:37',
'14:37',
'14:37',
'14:37',
'14:46',
'14:46',
'14:46',
'14:46',
'14:55',
'14:55',
'14:55',
'15:05',
'15:05',
'15:05',
'15:05',
'15:14',
'15:14',
'15:14',
'15:14',
'15:23',
'15:23',
'15:23',
'15:23',
'15:32',
'15:32',
'15:32',
'15:32',
'15:42',
'15:42',
'15:42',
'15:42',
'15:51',
'15:51',
'15:51',
'15:51',
'16:00',
'16:00',
'16:00',
'16:00',
'16:09',
'16:09',
'16:09',
'16:09',
'16:19',
'16:19',
'16:19',
'16:19',
'16:28',
'16:28',
'16:28',
'16:28',
'16:37',
'16:37',
'16:37',
'16:37',
'16:46',
'16:46',
'16:46',
'16:46',
'16:56',
'16:56',
'16:56',
'16:56',
'17:05',
'17:05',
'17:05',
'17:05',
'17:14',
'17:14',
'17:14',
'17:14',
'17:23',
'17:23',
'17:23',
'17:23',
'17:33',
'17:33',
'17:33',
'17:33',
'17:42',
'17:42',
'17:42',
'17:42',
'17:51',
'17:51',
'17:51',
'17:51',
'18:00',
'18:00',
'18:00',
'18:00',
'18:10',
'18:10',
'18:10',
'18:10',
'18:19',
'18:19',
'18:19',
'18:19',
'18:28',
'18:28',
'18:28',
'18:28',
'18:37',
'18:37',
'18:37',
'18:37',
'18:47',
'18:47',
'18:47',
'18:47',
'18:57',
'18:57',
'18:57',
'18:57',
'19:06',
'19:06',
'19:06',
'19:06',
'19:15',
'19:15',
'19:15',
'19:15',
'19:24',
'19:24',
'19:24',
'19:24',
'19:33',
'19:33',
'19:33',
'19:33',
'19:42',
'19:42',
'19:42',
'19:42',
'19:52',
'19:52',
'19:52',
'19:52',
'20:01',
'20:01',
'20:01',
'20:01',
'20:10',
'20:10',
'20:10',
'20:10',
'20:19',
'20:19',
'20:19',
'20:19',
'20:28',
'20:28',
'20:28',
'20:28',
'20:37',
'20:37',
'20:37',
'20:37',
'20:47',
'20:47',
'20:47',
'20:47',
'20:56',
'20:56',
'20:56',
'20:56',
'21:05',
'21:05',
'21:05',
'21:05',
'21:14',
'21:14',
'21:14',
'21:14',
'21:24',
'21:24',
'21:24',
'21:24',
'21:33',
'21:33',
'21:33',
'21:33',
'21:42',
'21:42',
'21:42',
'21:42',
'21:51',
'21:51',
'21:51',
'21:51',
'22:01',
'22:01',
'22:01',
'22:01',
'22:10',
'22:10',
'22:10',
'22:19',
'22:19',
'22:19',
'22:19',
'22:28',
'22:28',
'22:28',
'22:28',
'22:38',
'22:38',
'22:38',
'22:38',
'22:47',
'22:47',
'22:47',
'22:47',
'22:56',
'22:56',
'22:56',
'22:56',
'23:05',
'23:05',
'23:05',
'23:05',
'23:15',
'23:15',
'23:15',
'23:15',
'23:24',
'23:24',
'23:24',
'23:24',
'23:33',
'23:33',
'23:33',
'23:33',
'23:42',
'23:42',
'23:42',
'23:42',
'23:52',
'23:52',
'23:52',
'23:52']

m = Counter(data);
#string = json.dumps(m)
from ast import literal_eval
string = repr(m)
f = open('23.doc', 'w')
f.write(string)
f.close()
#print(mylist)