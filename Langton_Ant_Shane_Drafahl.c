
#include <Linker.h>
char buffer[128][128];

int main(int argc, char *argv[])
{
  int i;

  start_encode(128, 128, 1);
  for (i = 0; i < 128; i++) {
    buffer[i][i] = 1;
    next_frame((char *) buffer);
  }
  finish_encode();

  return 0;
}
