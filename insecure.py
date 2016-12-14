#/bin/python
#Detect vulnerable insecure crodssdomain.xml files

import requests,os
import time,sys
 

class stx:    
	repstr=''
	RED='\033[1;31m'
	brown='\033[0;33m'
	Blue='\033[0;34m'
	Green='\033[1;32m'    
	FAIL = '\033[91m'
	ENDC = '\033[0m'
	yel = '\033[93m'
	White='\033[1;37m'
	crims=' \033[1;38m'
	magenta='\033[1;35m'	
 
requests.packages.urllib3.disable_warnings();
def  printx(o):
	sys.stdout.write(o)
	sys.stdout.flush()
def spaces(s,length):
	if len(s)>=length :
		return s
	return s+(' '*(length-len(s.strip())))

file_exits=False

path=''
file_extis=False

if len(sys.argv) > 1:
	path=sys.argv[1]
	file_exits=os.path.isfile(path)

while file_exits==False:
	path=raw_input('where is ur file')
	if os.path.isfile(path):
		file_exits=True
		print('File not found')

lines=[]
try:
	lines=open(path,'r').readlines()
except Exception:
	print ('error while reading file')

if len(lines) <1 :
	print 'empty file \n leaving'
counter=0
print(stx.White+'\n------------------------ starting -------------------')

longestlines=10
vulnerable_domains=[]
for x in lines: ##Formating output
	ln=len(x.strip())
	if ln > longestlines:
		longestlines=ln

for lin in lines:
	l=lin.strip()
	if len(l)<5:
		continue
	counter=counter+1
	if l.startswith('http://') or l.startswith('https://'):
		u=l
	else:
		u='http://'+l
	if u.endswith('/'):
		u=u+'crossdomain.xml'
	else:
		u=u+'/crossdomain.xml'
	done=False
	tryies=0
	while done==False and tryies<4:
		try:
			tryies=tryies+1
			printx(spaces( stx.Green+'\n'+ spaces(('['+str(counter)+']' if tryies==1 else ''),10)+ ' ['+str(tryies)+'] Trying "'+u+'"',longestlines+60))
			r=requests.get(url=u,timeout=3)
			done=True
			if "allow-access-from domain='*'" in r.text or 'allow-access-from domain="*"' in r.text:
				printx( l+' vulnerable\n')
				if l not in vulnerable_domains:
					vulnerable_domains.append(l)
			else:
				printx( stx.magenta+' not vulnerable\n')
		except Exception,e:
			errormsg=str(e)
			ErrorToPrin=errormsg
			if   'Max retries exceeded with url:' in errormsg :
				ErrorToPrin='Unreachable' 
			elif 'Read timed out' in errormsg:
				ErrorToPrin='Read Time out'
			printx (stx.RED+' Error  	'+stx.yel+' '+ErrorToPrin+'')
			time.sleep(3)

if len(vulnerable_domains) > 0:
	printx('\n Vulnerable domains')
	for l in vulnerable_domains:
		print(l)
else:
	printx('\n no vulnverable domains detecetd')
