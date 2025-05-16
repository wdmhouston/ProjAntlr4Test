grammar rec_conf;

start_rule
  : sub_ent* EOF
  ;
sub_ents
  :fm_section
  ;

fm_section
  :fm '{' fm_block* '}'
  ;

fm_block
  :FM string
  | p1 string
  | p2 string
  ;
 
WS : [ \t\r\n]+ -> skip ;