#!/bin/sh
find private codes -type f|while read i;do
	MD5A=$(md5sum "$i" | sed -e 's/ .*//g')
	MD5B=$(md5sum "/cygdrive/d/$i" | sed -e 's/ .*//g')
	if [ $MD5A != $MD5B ];then
		cp -v "$i" "/cygdrive/d/$i"
	fi
done
