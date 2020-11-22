# kvmwc
KVM Windows Console

I created this project for people who would like to have some kind of "windows console" for their KVM hypervisors. This project uses program called "plink.exe" which was created by Simon Tatham. 

Prerequisities:
=======================================

1.) Make sure you have KVM deployed on your machine

2.) to /etc/sudoers (use "visudo" command to prevent mistakes) add following lines:      
<username_here> ALL=NOPASSWD: /bin/virsh      
<username_here> ALL=NOPASSWD: /usr/bin/virsh      
<username_here> ALL=NOPASSWD: /usr/bin/virt-install      
  
3.) Download plink.exe and place it to the program root

4.) Enjoy.
