#include <stdio.h>
#include <string.h>
#include <stdlib.h>

struct _file {
    int inum;
    char string[255];
    float fnum;
};

int main(int argc, const char * argv[]) {
    int right = 0;
    struct _file rf;
    char fpath[255];
    FILE *f = NULL;
    while(right==0){
    printf("Enter the path to the file\n");
    fgets(fpath, 255, stdin);
    fpath[strlen(fpath)-1] = '\0';
    if ((f = fopen(fpath, "r+b")) == NULL) perror ("Error 228");
    else {
        right = 1;
    }
    }
    int i = 0;
    while (!feof(f)) {
        fread(&rf, sizeof(rf), 1, f);
        printf("%d %s %f\n", rf.inum, rf.string, rf.fnum);
        i++;
    }
    
    printf("Element amount: %d\n", i-1);
    printf("File size: %ld byte/-s\n", ftell(f));
    fclose(f);
    return 0;
}
