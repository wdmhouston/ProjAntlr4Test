grammar Hello;

start_rule
  : sub_ents* EOF
  ;

sub_ents
  : fm_section
  ;

fm_section
  : FM '{' fm_block* '}'
  ;

fm_block
  : FM STRING
  | P1 STRING
  | P2 STRING
  | PREDICTION boolean
  ;

FM: F__ M__;
PREDICTION: P__ R__ E__ D__ I__ C__ T__ I__ O__ N__;
P1: P__ N1__;
P2: P__ N2__;
boolean : TRUE | FALSE;

TRUE: T__ R__ U__ E__;
FALSE: F__ A__ L__ S__ E__;

fragment A__: [aA];
fragment B__: [bB];
fragment C__: [cC];
fragment D__: [dD];
fragment E__: [eE];
fragment F__: [fF];
fragment G__: [gG];
fragment H__: [hH];
fragment I__: [iI];
fragment J__: [jJ];
fragment K__: [kK];
fragment L__: [lL];
fragment M__: [mM];
fragment N__: [nN];
fragment O__: [oO];
fragment P__: [pP];
fragment Q__: [qQ];
fragment R__: [rR];
fragment S__: [sS];
fragment T__: [tT];
fragment U__: [uU];
fragment V__: [vV];
fragment W__: [wW];
fragment X__: [xX];
fragment Y__: [yY];
fragment Z__: [zZ];
fragment N1__: [1];
fragment N2__: [2];

WS: [ \t\r\n]+ ->skip; // skip spaces, tabs, newlines
STRING  : '\'' .*? '\'';
