training = 1:10;

up_focus_ok = [2 1 1 8 6 8 9 9 8 9];
up_focus_bad = [8 9 9 2 4 2 1 1 2 1];
up_nofocus_ok = [10 10 10 6 8 5 4 3 7 5];
up_nofocus_bad = [ 0 0 0 4 2 5 6 7 3 5];

right_focus_ok = [0 0 0 0 1 0 0 1 2 1];
right_focus_bad = [10 10 10 10 9 10 10 9 8 9];
right_nofocus_ok = [ 6 8 10 10 10 10 10 10 10 10];
right_nofocus_bad = [4 2 0 0 0 0 0 0 0 0];

down_focus_ok = [0 0 0 1 1 4 2 2 3 3];
down_focus_bad = [10 10 10 9 9 6 8 8 7 7];
down_nofocus_ok = [10 10 10 8 9 9 10 10 10 10];
down_nofocus_bad = [0 0 0 2 1 1 0 0 0 0];

left_focus_ok = [0 0 0 1 1 2 1 3 2 3];
left_focus_bad = [10 10 10 9 9 8 9 7 8 7];
left_nofocus_ok = [10 10 10 10 10 9 10 10 10 10];
left_nofocus_bad = [0 0 0 0 0 1 0 0 0 0];

frown_focus_ok = [10 10 10 10 10 10 10 10 10 10];
frown_focus_bad = [0 0 0 0 0 0 0 0 0 0];
frown_nofocus_ok = [3 4 4 4 6 5 6 4 5 5];
frown_nofocus_bad = [7 6 6 6 4 5 4 6 5 5];

up = figure;
hold on
xlim([1 10]); ylim([0 100])
xlabel('Numer treningu'); ylabel('Stosunek detekcji do iloœci prób [%]');
plot(training, up_focus_ok * 10, '-o');
plot(training,up_nofocus_bad * 10, '--o');
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia','Location','northwest');

right = figure;
hold on
xlim([1 10]); ylim([0 100])
xlabel('Numer treningu'); ylabel('Stosunek detekcji do iloœci prób [%]');
plot(training,right_focus_ok * 10, '-o');
plot(training,right_nofocus_bad * 10, '--o');
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia','Location','northwest');

down = figure;
hold on
xlim([1 10]); ylim([0 100])
xlabel('Numer treningu'); ylabel('Stosunek detekcji do iloœci prób [%]');
plot(training,down_focus_ok * 10, '-o');
plot(training,down_nofocus_bad * 10, '--o');
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia','Location','northwest');

left = figure;
hold on
xlim([1 10]); ylim([0 100])
xlabel('Numer treningu'); ylabel('Stosunek detekcji do iloœci prób [%]');
plot(training,left_focus_ok * 10, '-o');
plot(training,left_nofocus_bad * 10, '--o');
legend('Detekcja podczas skupienia','Detekcja podczas braku skupienia','Location','northwest');

frown = figure;
hold on
xlim([1 10]); ylim([0 100])
xlabel('Numer treningu'); ylabel('Stosunek detekcji do iloœci prób [%]');
plot(training,frown_focus_ok * 10, '-o');
plot(training,frown_nofocus_bad * 10, '--o');
legend('Detekcja podczas wykonania','Detekcja podczas braku wykonania','Location','northwest');

set(up, 'Units', 'Inches');
pos = get(up, 'Position');
set(up, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(up, 'up', '-dpdf', '-r0');

set(right, 'Units', 'Inches');
pos = get(right, 'Position');
set(right, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(right, 'right', '-dpdf', '-r0');

set(down, 'Units', 'Inches');
pos = get(down, 'Position');
set(down, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(down, 'down', '-dpdf', '-r0');

set(left, 'Units', 'Inches');
pos = get(left, 'Position');
set(left, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(left, 'left', '-dpdf', '-r0');

set(frown, 'Units', 'Inches');
pos = get(frown, 'Position');
set(frown, 'PaperPositionMode','Auto','PaperUnits','Inches','PaperSize',[pos(3),pos(4)]);
print(frown, 'frown', '-dpdf', '-r0');