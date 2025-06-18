import type { Router } from 'vue-router';

export function setupGuard(router: Router) {
  router.beforeEach((to, from, next) => {
    next();
  });
}
