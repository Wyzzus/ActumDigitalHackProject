import pymysql
db = pymysql.connect("77.222.63.58","kgpd02","Wzfuv175","samarityanin", charset='utf8')
f = open('data.txt', 'w')
k = open('test.txt', 'r')
l = k.readline()
cursor = db.cursor()
sql = l
cursor.execute(sql)
results = cursor.fetchall()
print(results)
f.write(str(results))
db.close
f.close()
