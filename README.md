# kvmwc
KVM Windows Console

I created this project for people who would like to have some kind of "windows console" for their KVM hypervisors. It is very simple program and does not contain any special features. This project uses program called "plink.exe" which was created by Simon Tatham. 

Prerequisities:
=======================================

1.) Make sure you have KVM deployed on your machine

2.) to /etc/sudoers (use "visudo" command to prevent mistakes) add following lines:     
<username_here> ALL=NOPASSWD: /bin/virsh     
<username_here> ALL=NOPASSWD: /usr/bin/virsh     
<username_here> ALL=NOPASSWD: /usr/bin/virt-install     
<username_here> ALL=NOPASSWD: /usr/bin/virt-clone     

3.) Enjoy.